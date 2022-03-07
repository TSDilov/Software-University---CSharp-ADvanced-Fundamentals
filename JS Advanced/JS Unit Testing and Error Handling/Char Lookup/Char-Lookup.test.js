
const { assert } = require('chai');
let lookupChar = require('./Char-Lookup');

it('Should return undifined if first parameter is not a string or if second parameter is not a number', () => {
    let resultWithFirstParameterNotString = lookupChar(25, 2);
    assert.isUndefined(resultWithFirstParameterNotString);
    let resultWithSecondParameterNotNumber = lookupChar('I am Ceci!', '2');
    assert.isUndefined(resultWithSecondParameterNotNumber);
    let resultIfIndexISFloatingNumber = lookupChar('I am Ceci!', 2.2);
    assert.isUndefined(resultIfIndexISFloatingNumber);
});

it('Should return incorect answer if index is out of the range of the string', () => {
    let resultWithIndexLowerThanZero = lookupChar('I am Ceci!', -1);
    assert.equal(resultWithIndexLowerThanZero, 'Incorrect index');
    let resultWitnIndexBiggerThanStringLength = lookupChar('I am Ceci!', 10);
    assert.equal(resultWitnIndexBiggerThanStringLength, 'Incorrect index');
});

it('Should return correct answer if the parameters are correct', () => {
    let result = lookupChar('I am Ceci!', 0);
    assert.equal(result, 'I');
    let result2 = lookupChar('I am Ceci!', 5);
    assert.equal(result2, 'C');
    let result3 = lookupChar('I am Ceci!', 9);
    assert.equal(result3, '!');
});
