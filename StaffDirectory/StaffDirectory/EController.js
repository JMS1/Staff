var controllerId = 'eController';

angular.module('app')
    .controller(controllerId, ['$scope' ,eController]);

function eController($scope) {
    $scope.employees;

    getEmployees();

    function getEmployees() {
        empFactory.getEmployees()
            .success(function (emps) {
                $scope.employees = emps;
            })

    }

};