import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tempConvert'
})
export class TempConvertPipe implements PipeTransform {

  transform(value: number,unit:String): unknown {
    var temp=0;
    if(unit=='C')
    {
      temp=(value-32)/1.8;

    }
    else if(unit=='F')
    {
      temp=(value*1.8)+32;
    }
    return temp;
  }

}
