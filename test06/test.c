#include <stdio.h>
#include <glib.h>
#include <sys/time.h>

// gcc test05/test.c `pkg-config glib-2.0 --cflags --libs` -o tmp/test_gcc

long current_timestamp() {
    struct timeval tv; 
    gettimeofday(&tv, NULL);
    return tv.tv_sec*1000LL + tv.tv_usec/1000;
}

int main(){

    long total = 0;
    GHashTable *map = g_hash_table_new(g_int_hash, g_int_equal);

    long time1 = current_timestamp();
    for(int i=0;i<25000000;i++){
        g_hash_table_insert(map, &i, &i);
    }
    long time2 = current_timestamp();
    printf("HashMap put %ld ms\n", time2-time1);

    char c;
    scanf("%c", &c);

    long time3 = current_timestamp();
    for(int i=0;i<25000000;i++){
        total += *(int *)g_hash_table_lookup(map, &i);
    }
    long time4 = current_timestamp();
    printf("total = %ld\n", total);
    printf("HashMap get %ld ms\n", time4-time3);

    return 0;
}

