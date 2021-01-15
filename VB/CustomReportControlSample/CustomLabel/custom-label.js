// Implement the __extends function.
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();

function customizeToolbox(s, e, shortTypeName, fullTypeName) {
    // Obtain standard label information.
    var controlsFactory = e.ControlsFactory;
    var labelInfo = controlsFactory.getControlInfo("XRLabel");
    var stringInfo = controlsFactory.getPropertyInfo("XRLabel", "Text");
    var objectEditor = controlsFactory.getPropertyInfo("XRLabel", "Size").editor;
    var numberInfo = controlsFactory.getPropertyInfo("XRLabel", "Angle");


    // Create serialization information for custom properties.

    var addressSerializationInfos = [
        $.extend({}, stringInfo, { propertyName: "countryCode", modelName: "@CountryCode", displayName: "CountryCode", localizationId: "" }),
        $.extend({}, stringInfo, { propertyName: "city", modelName: "@City", displayName: "City", localizationId: "" }),
    ];

    var customerSerializationInfo = {
        propertyName: "customerInfo", modelName: "customerInfo", displayName: "Customer Information", defaultVal: "", localizationId: "",
        editor: objectEditor, info: addressSerializationInfos
    }

    var customNumberSerializationInfo = $.extend({}, numberInfo,
        { propertyName: "customNumber", modelName: "@CustomNumber", displayName: "Custom Number", defaultVal: 0, localizationId: "" }
    );

    var bindablePropertySerializationInfo = $.extend({}, stringInfo, {
        propertyName: "stringData", modelName: "@StringData", displayName: "Bindable Property", defaultVal: "", localizationId: ""
    });

    // Create the custom label's surface type.
    var CustomLabelSurface = (function (_super) {
        __extends(CustomLabelSurface, _super);
        function CustomLabelSurface(control, context) {
            _super.call(this, control, context);
            this.contenttemplate = "custom-label-content";
            this.displaySomeProperty = ko.computed(function () {
                var text = control["customNumber"] && control["customNumber"]();
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
            "@SizeF": "400,50"
        },
        toolboxIndex: 1,
        info: [customerSerializationInfo, bindablePropertySerializationInfo, customNumberSerializationInfo],
        popularProperties: ["customerInfo", "stringData", "customNumber"],
    });

    // Register the custom label in the Report Designer Toolbox.
    controlsFactory.registerControl(shortTypeName, customLabelInfo);

    // Adjust the custom label bindings if the report uses expression bindings (DataBindingMode is set to Expressions or ExpressionsAdvanced).
    var defaultExpression = controlsFactory.getPropertyInfo(shortTypeName, "Expression")
    defaultExpression.expressionName = "StringData"
    controlsFactory.setExpressionBinding(shortTypeName, "StringData", controlsFactory._beforePrintPrintOnPage);

    var dataBindings = controlsFactory.getPropertyInfo(shortTypeName, "Data Bindings");
    dataBindings.allDataBindings.push("StringData");
    var defaultBinding = controlsFactory.getPropertyInfo(shortTypeName, "Data Binding");
    defaultBinding.bindingName = "StringData";

    // Add a custom property to the Data category of the Property Grid.
    s.AddToPropertyGrid("Data", customerSerializationInfo);
    s.AddToPropertyGrid("Data", customNumberSerializationInfo);
}
