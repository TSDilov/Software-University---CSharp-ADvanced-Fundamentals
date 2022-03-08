const { assert } = require('chai');
let isSymmetric = require('./Check-for-Symmetry');

it('Should return false if the argument is not an array', () => {
    assert.equal(isSymmetric(25), false);
    assert.equal(isSymmetric(undefined), false);
    assert.equal(isSymmetric('some text'), false);
    assert.equal(isSymmetric(function(){}), false);
});

it('Should return false if the array is non symmetric', () => {
    assert.equal(isSymmetric([ 1, 2, 3 ]), false);
    assert.equal(isSymmetric([ 'a', 'b', 'c']),false);
})

it('Should return true if the array with numbers is symmetric', () => {
    assert.equal(isSymmetric([ 1, 2, 1 ]), true);
})

it('Should return true if the array with strings is symmetric', () => {
    assert.equal(isSymmetric([ 'a', 'b', 'a' ]), true);
})

it('Should return false if the array is mixed with different types', () => {
    assert.equal(isSymmetric([ 1, '2', 2, 1]), false);
})