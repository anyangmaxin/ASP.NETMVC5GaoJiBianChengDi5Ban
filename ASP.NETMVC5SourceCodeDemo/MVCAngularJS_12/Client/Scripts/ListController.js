
(function (app) {
    var ListController = function ($scope, movieService) {
        // $scope.message = "Hello,World";
        //$http.get("/api/movie")
        //    .success(function(data) {
        //        $scope.movies = data;
        //    }).error(function(data) {
        //        $scope.error = data;
        //    });

        movieService.getAll().success(function (data) {
            $scope.movies = data;
        }).error(function (data) {
            $scope.error = data;
        });

        $scope.create = function() {
            $scope.edit = {
                movie: {
                    Title: "",
                    Runtime: 0,
                    ReleaseYear:new Date().getFullYear()
                }
            };
        };
        var removeMovieById = function (id) {
            for (var i = 0; i < $scope.movies.length; i++) {
                if ($scope.movies[i].Id == id) {
                    $scope.movies.splice(i, 1);
                    break;
                }
            }
        };

        $scope.delete = function (movie) {
            movieService.delete(movie).success(function () {
                removeMovieById(movie.Id);
            });
        };

  
    };
    //ListController.$inject = ["$scope","$http"];
    app.controller("ListController", ListController);
}(angular.module("atTheMovies")));
/**
 * 这段代码使用的临时的调用函数表达式来代替创建全局变量。
 * 代码中虽然也使用了angular.module，但没有创建模块，而是引用了前面脚本创建的atTheMovies模块，
 * 这样在函数中就可以通过 变量app来访问atTheMovies模块。
 * 还有一种方法可以获取 atTheMovies的引用
 * (function(app){var app=angular.module("atTheMovies");}());
 */
