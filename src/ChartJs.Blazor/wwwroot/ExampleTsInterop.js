/// <reference path="types/moment.d.ts" />
/// <reference path="types/Chart.min.d.ts" />   
class ExampleJsFunctions {
    showPrompt(message) {
        return prompt(message, 'Type anything here' + moment.now() + Chart.defaults.global.defaultFontFamily);
    }
}
function Load() {
    window['exampleJsFunctions'] = new ExampleJsFunctions();
}
Load();
//# sourceMappingURL=ExampleTsInterop.js.map