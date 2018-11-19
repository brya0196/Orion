
(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("AddVentasController", ["$scope", "ProductosRepository", "UsuariosRepository", "VentasRepository", AddVentasController]);

    function AddVentasController($scope, ProductosRepository, UsuariosRepository, VentasRepository) {

        const vm = this;

        $scope.Venta = {};
        vm.Productos = [];
        vm.Vendedores = [];

        ProductosRepository.getAll()
            .then(Productos => vm.Productos = Productos.value)
            .catch(err => console.log(err));

        UsuariosRepository.getAll()
            .then(Vendedores => vm.Vendedores = Vendedores.value)
            .catch(err => console.log(err));


        vm.addVentas = () => {
            VentasRepository.add($scope.Venta)
                .then(response => window.location.replace("/Home/Ventas"))
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/Ventas");

    }

})();