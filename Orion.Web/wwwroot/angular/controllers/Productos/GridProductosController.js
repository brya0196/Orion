(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("GridProductosController", ["$scope", "StoreService", "ProductosRepository", GridProductosController]);

    function GridProductosController($scope, StoreService, ProductosRepository) {

        var vm = this;

        vm.Productos = [];
        populateGrid();

        vm.delete = id => {
            ProductosRepository.delete(id)
                .then(response => {
                    alert("Eliminado");
                    vm.Productos = [];
                    populateGrid();
                })
                .catch(err => console.log(err));
        };

        vm.update = id => {
            StoreService.Set("updateUsuario", id);
            window.location.href = "/Home/UpdateUsuarios";
        };

        vm.password = id => {
            StoreService.Set("updateUsuarioPassword", id);
            window.location.href = "/Home/UpdateUsuariosPassword";
        };

        function populateGrid() {
            ProductosRepository.getAll()
                .then(productos => vm.Productos = productos.value)
                .catch(err => console.log(err));
        }
    }

})();