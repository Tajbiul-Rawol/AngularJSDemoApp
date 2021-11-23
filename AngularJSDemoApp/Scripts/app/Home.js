var myApp = angular.module("myApp", []);

myApp.controller("homeController", function ($scope) {
    $scope.yourName = "";
});

var app = angular.module('HomeApp', []);
app.controller('HomeController', function ($scope, $http) {

    $scope.model = "";

    $http({
        method: 'GET',
        url: '@Url.Action("getEmployee", "Home")',
        headers: {
            'Content-type': 'application/json'
        }
    }).then(function (response) {
        debugger;
        $scope.employee = JSON.parse(response.data);
    }, function (error) {
        console.log(error);
    });

    $scope.AddEmployee = function () {
        debugger;
        var eee = $scope.model;
        $http({
            method: 'POST',
            url: '@Url.Action("AddEmployee", "Home")',
            data: $scope.model,
            headers: {
                'Content-type': 'application/json'
            }
        }).then(function (response) {
            $scope.employee = JSON.parse(response.data);
            $scope.message = "Employee added Successfully";

            $("#AddModal").modal("hide");
        }, function (error) {
            console.log(error);
        });
    }

    $scope.selectUser = function (names) {
        $scope.selectedUser = names;
    }

    $scope.UpdateEmployee = function () {
        var eee = $scope.selectedUser;
        $http({
            method: 'POST',
            url: '@Url.Action("UpdateEmployee", "Home")',
            data: $scope.selectedUser,
            headers: {
                'Content-type': 'application/json'
            }
        }).then(function (response) {
            $scope.employee = JSON.parse(response.data);
            $scope.message = "Employee updated Successfully";
            $("#EditModal").modal("hide");
        }, function (error) {
            console.log(error);
        });
    }

    $scope.DeleteEmployee = function (names) {

        $http({
            method: 'POST',
            url: '@Url.Action("DeleteEmployee", "Home")',
            data: names,
            headers: {
                'Content-type': 'application/json'
            }
        }).then(function (response) {
            $scope.employee = JSON.parse(response.data);
            $scope.message = "Employee Deleted Successfully";
            $("#EditModal").modal("hide");
        }, function (error) {
            console.log(error);
        });
    }
    $scope.clearModel = function () {
        $scope.model = null;

    }

});