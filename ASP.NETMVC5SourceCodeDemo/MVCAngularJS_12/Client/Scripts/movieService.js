(function (app) {
    var movieService = function ($http, movieApiUrl) {
        var getAll = function () {
            return $http.get(movieApiUrl);
        };

        var getById = function (id) {
            return $http.get(movieApiUrl + id);
        };

        var update = function (movie) {
            return $http.put(movieApiUrl + movie.Id, movie);
        };
        var create = function (movie) {
            return $http.post(movieApiUrl, movie);
        };

        var destroy = function (movie) {
            return $http.delete(movieApiUrl + movie.Id);
        };

        return {
            getAll: getAll,
            getById: getById,
            update: update,
            create: create,
            delete: destroy
        };
    };
    app.factory("movieService", movieService);
}(angular.module("atTheMovies")));

/**
 * 上面的服务是在通过 提供检索列表的方法模拟MovieController的服务器端api，通过id获取 更新 创建 和删除电影令牌。
 * 这其中的每个方法都 调用$http服务---movieService的依赖
 * movieService的另一个依赖是movieApiUrl。
 */