#include <stdio.h>
#include <stdint.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    if( argc != 2 ) goto end_with_error;
    int counter = atoi(argv[1]);
    if( counter != 25000 ) goto end_with_error;

    uint64_t sum = 0;
    for(uint32_t i=0;i<counter;i++){
        for(uint32_t j=0;j<counter;j++){
            sum += 1 + i*2 + j*3;
        }
    }
    printf("sum = %ld\n", sum);
    return 0;

end_with_error:
    printf("Run with parameter of 25000 !\n");
    return 1;
}

