(function () {
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.factory("StoreService", [StoreService]);
    
    function StoreService() {
        
        if(JSON.parse(localStorage.getItem("Store")) == null) 
            localStorage.setItem("Store", JSON.stringify({}));
        
        const Set = (key, value) => {
            let store = localStorage.getItem("Store");
            store = JSON.parse(store);
            store[key] = value
            localStorage.setItem("Store", JSON.stringify(store));
        };
        
        const Remove = (key) => {
            let store = localStorage.getItem("Store");
            store = JSON.parse(store);
            delete store[key]
            localStorage.setItem("Store", JSON.stringify(store));
        };
        
        const Find = key => {
            let store = localStorage.getItem("Store");
            store = JSON.parse(store);
            return store[key];
        };
        
        const GetAll = () => {
            let store = localStorage.getItem("Store");
            return JSON.parse(store);
        };
        
        return {
            Set: Set,
            Remove: Remove,
            Find: Find,
            GetAll: GetAll
        }
    }
    
})();