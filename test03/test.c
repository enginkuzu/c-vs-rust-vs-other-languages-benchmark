#include <stdio.h>
#include <stdint.h>

int main(){
    uint64_t sum = 0;
    for(uint32_t i=0;i<25000;i++){
        for(uint32_t j=0;j<25000;j++){
            sum += 1 + i*2 + j*3;
        }
    }
    printf("sum = %ld\n", sum);
    return 0;
}

