(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("FacturaController", ["$scope", "StoreService", "VentasRepository", FacturaController]);

    function FacturaController($scope, StoreService, VentasRepository) {

        const vm = this;

        vm.Venta = StoreService.Find("venta");

        StoreService.Remove("venta");

        vm.cancel = () => window.location.replace("/Home/Ventas");

    }

})();