angular.module('common.services')
    .factory('employeeResource',
            ['$resource', 'appSettings',
                employeeResource])

function employeeResource($resource, appSettings) {
    return $resource(appSettings.serverpath + '/api/test');




}