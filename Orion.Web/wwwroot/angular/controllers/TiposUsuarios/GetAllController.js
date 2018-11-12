(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.controller("GetAllController", ["$scope", GetAllController]);
    
    function GetAllController($scope) {
        $scope.sayHi = "Hi";
    }
    
})();