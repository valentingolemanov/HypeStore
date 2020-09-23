import {IProduct} from './../product/IProduct.interface';


export class Product {

  Id: number;
  Title: string;
  Description: string;
  ImagesUrl: string[];
  Price: number;
  BrandName: string;
  BrandId: number;
  CollectionIds: number[];
  AddedOn: string;
  LastModified: string;

}
