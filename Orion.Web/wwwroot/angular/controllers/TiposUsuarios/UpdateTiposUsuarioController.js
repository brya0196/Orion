(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.controller("UpdateTiposUsuariosController", ["$scope", "StoreService", "TiposUsuariosRepository", UpdateTiposUsuariosController]);

    function UpdateTiposUsuariosController($scope, StoreService, TiposUsuariosRepository) {

        const vm = this;

        $scope.TipoUsuario = {};
        
        TiposUsuariosRepository.getById(StoreService.Find("updateTipoUsuario"))
            .then(response => $scope.TipoUsuario = response.value)
            .catch(err => console.log(err));

        vm.updateTipoUsuario = () => {
            TiposUsuariosRepository.update($scope.TipoUsuario)
                .then(response => {
                    StoreService.Remove("updateTipoUsuario");
                    window.location.replace("/Home/TiposUsuarios");
                })
                .catch(err => console.log(err));
        };

        vm.cancel = () => window.location.replace("/Home/TiposUsuarios");

    }

})();