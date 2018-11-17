(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("UpdateUsuarioPasswordController", ["$scope", "StoreService", "UsuariosRepository", UpdateUsuarioPasswordController]);

    function UpdateUsuarioPasswordController($scope, StoreService, UsuariosRepository) {

        const vm = this;

        $scope.Usuario = {};

        UsuariosRepository.getById(StoreService.Find("updateUsuarioPassword"))
            .then(response => $scope.Usuario = response.value)
            .catch(err => console.log(err));

        StoreService.Remove("updateUsuarioPassword");


        vm.updateUsuario = () => {
            UsuariosRepository.update($scope.Usuario)
                .then(response => window.location.replace("/Home/Usuarios"))
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/Usuarios");

    }

})();