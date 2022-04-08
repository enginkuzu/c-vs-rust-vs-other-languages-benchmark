package main
import "fmt"
import "os"
import "strconv"
func main() {

    if len(os.Args) != 2 {
        fmt.Println("Run with parameter of 25000 !");
        return;
    }
    _tmp, _ := strconv.Atoi(os.Args[1]);
    counter := uint32(_tmp);
    if counter != 25000 {
        fmt.Println("Run with parameter of 25000 !");
        return;
    }

    var sum uint64 = 0;
    var i uint32;
    for i=0; i<counter; i++ {
        var j uint32;
        for j=0; j<counter; j++ {
            sum += uint64( 1 + i*2 + j*3 );
        }
    }
    fmt.Println("sum =", sum);
}

