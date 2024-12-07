/*

------DYNAMİC---------
    var anahtar kelimesi, tür çıkarımı ya da (type inference) sağlayan bir kelimedir. Derleyici, değişkenin türünü atanan deüerden bakarak otomatik olarka belirler. Derleme zamanında bu tür sabit bir şekilde belirlenmiş olur.

    - var kullanımı, yütün açık bir şekilde belli olduğu durumlarda kullanılırsa daha sağlıklı olur.
    - Tür bir kez belirkendikten sonra değiştirilemez.

*/
     var number = 5 ;
     var name ="Ali";

    // var price; // yanlış kullanım

    /*
        dynamic, derleme zamanında yür kontrolü yapmadan çalışma zamnında gerçek olarak bu çıkarsamanın yapılmasını sağlar.
        bu yönüyle daha esnek bir yapı sunarken , hatalara da daha açık bir tekniktir.
    */
    //  var a=5;
    //   a="Ali";
    //************

    dynamic a=5;
    System.Console.WriteLine(a);
    a="Ali";
    System.Console.WriteLine(a);