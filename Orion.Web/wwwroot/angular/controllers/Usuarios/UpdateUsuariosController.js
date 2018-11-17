(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("UpdateUsuariosController", ["$scope", "StoreService", "TiposUsuariosRepository", "UsuariosRepository", UpdateUsuariosController]);

    function UpdateUsuariosController($scope, StoreService, TiposUsuariosRepository, UsuariosRepository) {

        const vm = this;

        $scope.Usuario = {};
        vm.tiposUsuarios = [];

        TiposUsuariosRepository.getAll()
            .then(tiposUsuarios => vm.tiposUsuarios = tiposUsuarios.value)
            .catch(err => console.log(err));

        UsuariosRepository.getById(StoreService.Find("updateUsuario"))
            .then(response => $scope.Usuario = response.value)
            .catch(err => console.log(err));
        
        StoreService.Remove("updateUsuario");


        vm.updateUsuario = () => {
            UsuariosRepository.update($scope.Usuario)
                .then(response => window.location.replace("/Home/Usuarios"))
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/Usuarios");

    }

})();