(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("AddUsuariosController", ["$scope", "TiposUsuariosRepository", "UsuariosRepository", AddUsuariosController]);

    function AddUsuariosController($scope, TiposUsuariosRepository, UsuariosRepository) {

        const vm = this;

        $scope.Usuario = {};
        vm.tiposUsuarios = [];

        TiposUsuariosRepository.getAll()
            .then(tiposUsuarios => vm.tiposUsuarios = tiposUsuarios.value)
            .catch(err => console.log(err));
        

        vm.addUsuario = () => {
            UsuariosRepository.add($scope.Usuario)
                .then(response => window.location.replace("/Home/Usuarios"))
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/Usuarios");

    }

})();