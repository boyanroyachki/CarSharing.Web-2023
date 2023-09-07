'use strict';

function solve(input) {
    let sum = 0;
    for (let i = 0; i < input.length; i++) {
        if (Number(input[i]) % 2 == 0) {
            sum += Number(input[i]);
        }
    }
    console.log(sum);
}
solve(2, 4, 6, 7, 9, 11);