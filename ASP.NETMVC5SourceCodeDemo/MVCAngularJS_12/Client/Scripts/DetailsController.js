﻿(function (app) {
    var DetailsController = function ($scope, $routeParams,movieService) {
        var id = $routeParams.id;
        //$http.get("/api/movie/" + id)
        //.success(function (data) {
        //    $scope.movie = data;
        //});
        movieService.getById(id).success(function(data) {
            $scope.movie = data;
        });

        $scope.edit = function() {
            $scope.edit.movie = angular.copy($scope.movie);
        };
    };
    app.controller("DetailsController", DetailsController);
}(angular.module("atTheMovies")));