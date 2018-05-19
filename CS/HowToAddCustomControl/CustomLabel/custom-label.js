function customizeToolbox(s, e, shortTypeName, fullTypeName) {
    // Obtain a standard label's information.
    var controlsFactory = e.ControlsFactory;
    var labelInfo = controlsFactory.getControlInfo("XRLabel");
    var baseSerializationInfo = controlsFactory.getPropertyInfo("XRLabel", "Text");

    // Create serialization information for a custom label's properties.
    var somePropertySerializationInfo = $.extend({}, baseSerializationInfo, {
        propertyName: "someProperty", modelName: "@SomeProperty", displayName: "Some Property", defaultVal: "", localizationId: ""
    });
    var bindablePropertySerializationInfo = $.extend({}, baseSerializationInfo, {
        propertyName: "bindableProperty", modelName: "@BindableProperty", displayName: "Bindable Property", defaultVal: "", localizationId: ""
    });

    // Create the custom label's surface type.
    var CustomLabelSurface = (function (_super) {
        __extends(CustomLabelSurface, _super);
        function CustomLabelSurface(control, context) {
            _super.call(this, control, context);
            this.contenttemplate = "custom-label-content";
            this.displaySomeProperty = ko.computed(function () {
                var text = control["someProperty"] && control["someProperty"]();
                return text ? text : (control["text"] && control["text"]() || "");
            });
        }
        return CustomLabelSurface;
    })(labelInfo.surfaceType);

    // Create an object containing info about a custom label toolbox item.
    var customLabelInfo = controlsFactory.inheritControl("XRLabel", {
        surfaceType: CustomLabelSurface,
        defaultVal: {
            "@ControlType": fullTypeName,
            "@SizeF": "100,23"
        },
        toolboxIndex: 1,
        info: [somePropertySerializationInfo, bindablePropertySerializationInfo],
        popularProperties: ["someProperty", "bindableProperty"],
    });

    // Register the custom label in the Report Designer Toolbox.
    controlsFactory.registerControl(shortTypeName, customLabelInfo);

    // Adjust the custom label's bindings depending on a report's data binding mode:
    // - if the report uses expression bindings (DataBindingMode is set to Expressions or ExpressionsAdvanced)
    var defaultExpression = controlsFactory.getPropertyInfo(shortTypeName, "Expression")
    defaultExpression.expressionName = "BindableProperty"
    controlsFactory.setPropertyDescription(shortTypeName, "BindableProperty", controlsFactory._beforePrintPrintOnPage);

    // - if the report uses data bindings (DataBindingMode is set to Bindings)
    ["BindableProperty"].forEach(function (name) {
        DevExpress.Designer.Report.dataBindingsSerializationInfo.push({
            propertyName: name, displayName: name,
            editor: DevExpress.Designer.Report.editorTemplates.dataBinding
        });
    });
    var dataBindings = controlsFactory.getPropertyInfo(shortTypeName, "Data Bindings");
    dataBindings.allDataBindings.push("BindableProperty");
    var defaultBinding = controlsFactory.getPropertyInfo(shortTypeName, "Data Binding");
    defaultBinding.bindingName = "BindableProperty";

    // Add a custom property to the Data category of the Property Grid.
    s.AddToPropertyGrid("Data", somePropertySerializationInfo);
}
