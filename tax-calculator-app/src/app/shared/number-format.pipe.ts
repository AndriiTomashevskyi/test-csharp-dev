import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'numberFormat'
})
export class NumberFormatPipe implements PipeTransform {

  transform(value: number): string {
    return value % 1 === 0 ? value.toFixed(0) : value.toFixed(2);
  }

}
