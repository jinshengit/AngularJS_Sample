angular.module("sportsStore")
.constant('productUrl', "http://localhost:57623/api/Product")
.controller("sportsStoreCtrl", function ($scope, $http, $location, productUrl) {
    $scope.data = [];

    $http.get(productUrl).success(function (data) {
        $scope.data.products = data;
    }).error(function (error) {
        $scope.data.error = error;
    });
});