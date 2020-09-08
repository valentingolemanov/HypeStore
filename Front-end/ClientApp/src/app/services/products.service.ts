import { Injectable, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {ICreateProduct} from '../product/ICreateProduct.interface';
import { IProduct } from '../product/IProduct.interface';

@Injectable({
  providedIn: 'root'
})

export class ProductsService{

  constructor(private http: HttpClient) { }

  getAllProducts(){
    return this.http.get('http://localhost:58341/api/products').pipe(
      map(data => {
        const models: Array<IProduct> = [];
        for(const id in data){
          if(data.hasOwnProperty(id)){
            models.push(data[id]);
          }
        }
        return models;
      })
    );
  }

  createProduct(product: ICreateProduct){

    return this.http.post<ICreateProduct>('http://localhost:58341/api/products', product);

  }

  getProduct(id: number){
    return this.http.get('http://localhost:58341/api/products/' + id);
  }

}
