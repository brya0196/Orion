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
            StoreService.Set("updateTipoUsuario", id);
            window.location.href = "/Home/UpdateTiposUsuarios";
        };

        function populateGrid() {
            UsuariosRepository.getAll()
                .then(usuario => vm.Usuarios = usuario.value)
                .catch(err => console.log(err));
        }
    }

})();