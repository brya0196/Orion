(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.controller("GetAllController", ["$scope", "TiposUsuariosRepository", GetAllController]);
    
    function GetAllController($scope, TiposUsuariosRepository) {
        
        var vm = this;
        
        vm.TiposUsuarios = [];

        TiposUsuariosRepository.getAll()
            .then(tiposUsuario => vm.TiposUsuarios = tiposUsuario)
            .catch(err => console.log(err));
        
        vm.delete = id => {
            TiposUsuariosRepository.delete(id)
                .then(response => {
                    
                })
                .catch(err => console.log(err));
        };
    }
    
})();