function requestValidator(requestObject) {
    const requestMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    const uriRegex = /^([\w\d\.]+|\*)$/g;
    const httpVersion = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    const messageRegex = /^([^<>\\&'"]*)$/g;

    if (!requestMethods.includes(requestObject.method) || !requestObject.hasOwnProperty('method')) {
        throw new Error('Invalid request header: Invalid Method');
    }

    if (!uriRegex.test(requestObject.uri) || !requestObject.hasOwnProperty('uri')) {
        throw new Error('Invalid request header: Invalid URI');
    }

    if (!httpVersion.includes(requestObject.version || !requestObject.hasOwnProperty('version'))) {
        throw new Error('Invalid request header: Invalid Version');
    }

    if (!messageRegex.test(requestObject.message) || !requestObject.hasOwnProperty('message')) {       
        throw new Error('Invalid request header: Invalid Message');
    }

    return requestObject;
}

requestValidator({
    method: 'POST',
    uri: 'home.bash',
    version: 'HTTP/2.0'
  }
  );