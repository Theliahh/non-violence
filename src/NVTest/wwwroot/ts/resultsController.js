(function () {
    'use strict';

    angular
        .module('NVTapp',['ngCookies'])
        .controller('resultsController', ['$http','$cookies',resultsController]);


    function resultsController($http,$cookies) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'resultsController';
        vm.isBusy = false;
        vm.newResult = {
            "age": 0,
            "gender": "",
            "score" : 0
        };
        vm.score = 0;
        var cookies = $cookies;
        vm.genderOptions = [
          { name: 'Male' },
          { name: 'Female' },
          { name: 'Non-Binary' },
          {name:'Transgender'}
        ];
        vm.onlyNumbers = /^\d+$/;
        getResults();

        function getResults()
        {
            //Get score from cookie
            vm.score = cookies.get('score');
            vm.newResult.score = vm.score;
        }

        vm.checkAge = function()
        {
            if (vm.newResult.age < 100 && vm.newResult.age >= 13)
            {
                vm.isAgeGood = true;
            }
            else
            {
                vm.isAgeGood = false;
            }
        }

        vm.skipSurvey = function()
        {
            window.location = '/NVT/results';
        }
        vm.addResult = function () {
            vm.isBusy = true;
            vm.newResult.gender = vm.newResult.gender.name;
            $http.post("/api/results", vm.newResult)
            .then(function (response) {
                //success
                console.log(vm.newResult);
                console.log(response.data);
                
            }, function () {
                //failure

            })
            .finally(function () {
                vm.isBusy = false;
                window.location = '/NVT/results';
            });
        }
    }
})();
