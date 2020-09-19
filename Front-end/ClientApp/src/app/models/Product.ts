import {IProduct} from './../product/IProduct.interface';


export class Product implements IProduct{

  Id: number;
  Title: string;
  Description: string;
  ImageUrl: string;
  Price: number;
  BrandName: string;
  ReleasedOn: string;
  CollectionIds: number[];
}
