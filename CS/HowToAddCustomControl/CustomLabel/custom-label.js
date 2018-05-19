// Change data bindings of serialization information.
function getSerializationsInfoWithNewDataBindings(serializationsInfo, newDataBindingsName) {
    // Get data bindings.
    var dataBindings = serializationsInfo.filter(function (info) { return info.propertyName === "dataBindings" })[0];
    // Remove data bindings.
    serializationsInfo.splice(serializationsInfo.indexOf(dataBindings), 1);
    // Register new data bindings name in the property grid.
    newDataBindingsName.forEach(function (name) {
        DevExpress.Designer.Report.dataBindingsSerializationInfo.push({
            propertyName: name, displayName: name,
            editor: DevExpress.Designer.Report.editorTemplates.dataBinding
        });
    });
    // Create new data bindings.
    var newDataBindings = DevExpress.Designer.Report.dataBindings([].concat(dataBindings.allDataBindings,
                                                                        newDataBindingsName));
    // Change data bindings.
    return [].concat(serializationsInfo, newDataBindings);
}
// Create serialization information for custom control's properties.
var somePropertySerializationInfo = { propertyName: "someProperty", displayName: "Some Property",
    modelName: "@SomeProperty", defaultVal: "", editor: DevExpress.JS.Widgets.editorTemplates.text
};
var bindablePropertySerializationInfo = { propertyName: "bindableProperty", displayName: "Bindable Property",
    modelName: "@BindableProperty", defaultVal: "", editor: DevExpress.JS.Widgets.editorTemplates.text
};

// Create new serialization information.
var newSerializationsInfo = getSerializationsInfoWithNewDataBindings(
    DevExpress.Designer.Report.labelSerializationsInfo.slice(0), ["BindableProperty"]);
// Remove old default data binding.
newSerializationsInfo.splice(newSerializationsInfo.indexOf(newSerializationsInfo.filter(function (pr) {
    return pr.propertyName === "defaultDataBinding"
})[0]), 1);
// Create new default data binding.
var newDefaultBinding = DevExpress.Designer.Report.defaultDataBinding("BindableProperty");

newSerializationsInfo = [].concat(newSerializationsInfo, [somePropertySerializationInfo,
                                    bindablePropertySerializationInfo, newDefaultBinding]);

// Create new popular property.
var newPopularProperties = [].concat(DevExpress.Designer.Report.popularPropertiesLabel.slice(0),
                                        ["someProperty", "bindableProperty"]);

var CustomLabelSurface = (function (_super) {
    __extends(CustomLabelSurface, _super);
    // Custom label control visualization.
    function CustomLabelSurface(control, context) {
        _super.call(this, control, context);
        this.contenttemplate = "custom-label-content";
        this.displaySomeProperty = ko.computed(function () {
            var text = control["someProperty"] && control["someProperty"]();
            return text ? text : (control["text"] && control["text"]() ? control["text"]() : "");
        });
    }

    return CustomLabelSurface;
})(DevExpress.Designer.Report.ControlSurface);
