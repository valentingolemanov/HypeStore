import { Pipe, PipeTransform } from '@angular/core';
import {Product} from '../models/Product';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: Array<Product>, filterString: string): any[] {
    const resultArr = [];

    if(value.length === 0 || filterString === '' ){
      return value;
    }

    for(const item of value){
      if(item.Title.toLowerCase().includes(filterString.toLowerCase()) ||
             item.BrandName.toLowerCase().includes(filterString.toLowerCase())){
        resultArr.push(item);
      }

      return resultArr;
    }
  }
}
