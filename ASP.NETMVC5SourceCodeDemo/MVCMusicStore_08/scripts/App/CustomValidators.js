/// <reference path="../jquery.validate.min.js" />
/// <reference path="../jquery.validate.unobtrusive.min.js" />

//第一个参数适配器名称 ，它必须与服务器端规则设置的validationproperty值匹配
//第二个参数 是要从元数据中检索的参数的名称。
$.validator.unobtrusive.adapters.addSingleVal("maxwords", "wordcount");

$.validator.addMethod("maxwords", function(value, element, maxwords) {
    if (value) {
        if (value.length > maxwords) {
            return false;
        }
    }
    return true;
});