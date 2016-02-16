(function () {
    var app = angular.module("atTheMovies", ["ngRoute"]);
    var config = function ($routeProvider) {
        $routeProvider.when("/list", { templateUrl: "/client/views/list.html" })
            .when("/details/:id", { templateUrl: "/client/views/details.html" })
        .otherwise({ redirectTo: "/list" });
    };
    app.config(config);
    app.constant("movieApiUrl", "/api/movie/");
}());
/**
 * 变量angular 是全局Angular对象，和jquery api通过全局变量$获取一样，Angular通过 变量angular来访问顶级api  
 * 在前面的代码中，模块函数 创建了一个新模块atTheMovies，然而第二个参数 即空数组 ，声明了模块依赖
 * 从技术层面 讲，这个模块依赖于核心Angular模块 “ng” 但是不需要明确地罗列 
 * 
 * 
 * 
 * 可以使用constant方法注册常量值。这些值 使用第一个参数 作为key，使用第二个参数 作为key关联的值。
 */