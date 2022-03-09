const { assert } = require('chai');
let isOddOrEven = require('./Even-Or-Odd');

it('Should return undifined if the parameter is not a string', () => {
    let result = isOddOrEven(25);
    assert.isUndefined(result);
});

it('Should return odd if length of the string is odd number', () => {
    let result = isOddOrEven('I want to be a software engineer!');
    assert.equal(result, 'odd');
});

it('Should return even if length of the string is even number', () => {
    let result = isOddOrEven('I want to be a software engineer so I started to study in SoftUni.');
    assert.equal(result, 'even');
});