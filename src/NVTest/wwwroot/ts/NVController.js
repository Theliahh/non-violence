//NVController.js
(function () {

    "use strict";
    
    angular.module("NVTapp")
        .controller("NVController", nvController);
    
    function nvController($http) {

        var vm = this;
        vm.score = 0; //Score starts at 0
        vm.errorMessage = "";
        vm.Question = {
            questionNumber : 0,
            questionText : "",
            firstChoice : "",
            secondChoice: "",
            nvChoice: 1,
            isRelevant : true
        }

        vm.answeredQuestion = function (choice) {
            if(vm.Question.isRelevant == true)
            {
                if(vm.Question.nvChoice == choice)
                {
                    vm.score++; //We got a point!
                }
                else
                {
                    //You're violent, nothing happens
                }
                vm.nextQuestion();
            }
            else
            {
                vm.nextQuestion();
            }
        }

        vm.nextQuestion = function () {
            //Make httpget call here
            vm.Question.questionNumber++;
            $http.get("api/question/" + vm.Question.questionNumber)
            .then(function (response) {
                //success
                angular.copy(response.data, vm.Question);
            }, function (error) {
                //failure
                vm.errorMessage = "Failed to load question" + error;
            }); 
        }

        vm.nextQuestion();

    }

})();