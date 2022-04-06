package main
import "fmt"
func main() {
    var sum uint64 = 0;
    var i uint32;
    for i=0; i<25000; i++ {
        var j uint32;
        for j=0; j<25000; j++ {
            sum += uint64( 1 + i*2 + j*3 );
        }
    }
    fmt.Println("sum =", sum);
}

