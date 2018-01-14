var app = angular.module('MyApp', [])
app.controller('MyController', function ($scope, $http, $window) {
    $scope.IsVisible = false;
    $scope.Search = function () {
        debugger;
        var owner = '{Name: "' + $scope.Prefix + '" }';
        var post = $http({
            method: "POST",
            url: "/api/Owner/GetAnimals",
            dataType: 'json',
            data: owner,
            headers: { "Content-Type": "application/json" }
        });

        post.success(function (data, status) {
            $scope.Animals = data;
            $scope.IsVisible = true;
        });

        post.error(function (data, status) {
            $window.alert(data.Message);
        });
    }
    $scope.Search();
});