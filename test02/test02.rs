fn main() {
    let mut sum:u64 = 0;
    for i in 0u32..25000 {
        for j in 0u32..25000 {
            sum += (1 + i*2 + j*3) as u64;
        }
    }
    println!("sum = {}", sum);
}

