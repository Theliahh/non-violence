(function () {
    'use strict';

    angular
        .module('app')
        .controller('resultsController', resultsController);

    resultsController.$inject = ['$location']; 

    function resultsController($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'resultsController';

        getResults();

        function getResults()
        {

        }
    }
})();
