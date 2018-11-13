(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.controller("AddTiposUsuariosController", ["$scope", "TiposUsuariosRepository", AddTiposUsuariosController]);
    
    function AddTiposUsuariosController($scope, TiposUsuariosRepository) {
        
        const vm = this;
        
        $scope.TipoUsuario = {};
        
        vm.addTipoUsuario = () => {
            TiposUsuariosRepository.add($scope.TipoUsuario)
                .then(response => window.location.replace("/Home/TiposUsuarios"))
                .catch(err => console.log(err));
        };
        
        vm.cancel = () => window.location.replace("/Home/TiposUsuarios");
        
    }
    
})();