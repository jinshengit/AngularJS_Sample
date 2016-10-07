angular.module("sportsStore")
.constant('productUrl', "http://localhost:57623/api/Product")
.constant('orderSaveUrl',"http://localhost:57623/api/Order")
.controller("sportsStoreCtrl", function ($scope, $http, $location, productUrl, orderSaveUrl, cart) {
    $scope.data = [];

    $http.get(productUrl).success(function (data) {
        $scope.data.products = data;
    }).error(function (error) {
        $scope.data.error = error;
    });

    $scope.sendOrder = function(shippingDetails){
    	var order = angular.copy(shippingDetails);
    	order.products = cart.getProducts();
    	$http.post(orderSaveUrl, order)
    		.success(function(data){
    			$scope.data.orderId = data.Id;
    			cart.getProducts().length = 0;
    		})
    		.error(function(error){
    			$scope.data.orderError = error;
    		})
    		.finally(function(){
    			$location.path("/complete");
    		});
    }
});