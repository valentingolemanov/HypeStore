import {IProduct} from './../product/IProduct.interface';


export class Product implements IProduct{

  Id: number;
  Title: string;
  Description: string;
  ImagesUrl: string[];
  Price: number;
  BrandName: string;
  BrandId: number;
  ReleasedOn: string;
  CollectionIds: number[];
}
