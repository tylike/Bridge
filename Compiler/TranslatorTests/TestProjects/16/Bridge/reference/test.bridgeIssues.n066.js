﻿(function (globals) {
    "use strict";

    Bridge.define('Test.BridgeIssues.N066.Rectangle66', {
        statics: {
            getDefaultValue: function () { return new Test.BridgeIssues.N066.Rectangle66(); }
        },
        $constructor1: function (x1) {
            this.$initialize();
            (new Test.BridgeIssues.N066.Rectangle66.$constructor()).$clone(this);
        },
        $constructor2: function (x1, x2) {
            this.$initialize();
        },
        constructor: function () {
            this.$initialize();
        },
        $struct: true,
        $clone: function (to) { return this; }
    });
    
    
    
    Bridge.init();
})(this);
