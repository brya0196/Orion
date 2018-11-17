(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("GetAllController", ["$scope", "StoreService", "UsuariosRepository", GetAllController]);

    function GetAllController($scope, StoreService, UsuariosRepository) {

        var vm = this;

        vm.Usuarios = [];
        populateGrid();

        vm.delete = id => {
            UsuariosRepository.delete(id)
                .then(response => {
                    alert("Eliminado");
                    vm.Usuarios = [];
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
            UsuariosRepository.getAll()
                .then(usuario => vm.Usuarios = usuario.value)
                .catch(err => console.log(err));
        }
    }

})();