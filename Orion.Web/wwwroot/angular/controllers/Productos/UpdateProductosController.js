
(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("UpdateProductosController", ["$scope", "StoreService", "ProductosRepository", UpdateProductosController]);

    function UpdateProductosController($scope, StoreService, ProductosRepository) {

        const vm = this;

        $scope.Producto = {};

        ProductosRepository.getById(StoreService.Find("updateProducto"))
            .then(response => {
                response.value.fechaVencimiento = new Date(response.value.fechaVencimiento);
                $scope.Producto = response.value
            })
            .catch(err => console.log(err));

        StoreService.Remove("updateUsuario");

        vm.updateProducto = () => {
            ProductosRepository.update($scope.Producto)
                .then(response => window.location.replace("/Home/Productos"))
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/Productos");

    }

})();