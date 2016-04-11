(function () {

    angular.module("NVTapp", ['ngRoute'])
        .config(function($routeProvider) {

            $routeProvider.when("/"), {
                controller: "resultsController",
                controllerAs: "vm",
                templateUrl: ""
            }

        });

})();