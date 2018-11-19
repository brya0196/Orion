(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("GridVentasController", ["$scope", "StoreService", "VentasRepository", GridVentasController]);

    function GridVentasController($scope, StoreService, VentasRepository) {

        var vm = this;

        vm.Ventas = [];
        populateGrid();
        
        vm.factura = venta => {
            StoreService.Set("venta", venta);
            window.location.href = "/Home/Factura";
        };

        function populateGrid() {
            VentasRepository.getAll()
                .then(response => vm.Ventas = response.value)
                .catch(err => console.log(err));
        }
    }

})();
