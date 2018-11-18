(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("AddProductosController", ["$scope", "ProductosRepository", AddProductosController]);

    function AddProductosController($scope, ProductosRepository) {

        const vm = this;

        $scope.Producto = {};

        vm.addTipoUsuario = () => {
            ProductosRepository.add($scope.Producto)
                .then(response => window.location.replace("/Home/Productos"))
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/Productos");

    }

})();