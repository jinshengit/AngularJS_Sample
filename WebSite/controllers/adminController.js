angular.module("sportsStoreAdmin")
	.constant("authUrl", "http://localhost:57623/api/User/Login")
	.constant("ordersUrl", "http://localhost:57623/api/Order/GetOrders")
	.controller("authCtrl", function($scope, $http, $location, authUrl){
		$scope.authenticate = function(user, pass){
			$http.post(authUrl, {
				UserName: user,
				Password: pass
			}).success(function(data){
				$location.path("/main");
			}).error(function(error){
				$scope.authenticationError = error;
			});
		}
	})
	.controller("mainCtrl", function($scope){
		$scope.screens = ["Products", "Orders"];
		$scope.current = $scope.screens[0];

		$scope.setScreen = function(index){
			$scope.current = $scope.screens[index];
		};

		$scope.getScreen = function(){
			return $scope.current == "Products" ? "/views/adminProducts.html" : "/views/adminOrders.html";
		};
	})
	.controller("ordersCtrl", function($scope, $http, ordersUrl){
		$http.get(ordersUrl, {
			withCredentials: true
		})
		.success(function(data){
			$scope.orders = data;
		});

		$scope.selectedOrder;

		$scope.selectOrder = function(order){
			$scope.selectedOrder = order;
		};

		$scope.calcTotal = function(order){
			var total = 0;
			for(var i = 0; i < order.products.length; i++){
				total += order.products[i].Count * order.products[i].Price;
			}
			return total;
		};
	});