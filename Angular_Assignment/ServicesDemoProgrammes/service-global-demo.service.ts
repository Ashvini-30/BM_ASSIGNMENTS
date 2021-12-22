import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServiceGlobalDemoService {
  products:Product[]=[];


  constructor() { }
  getProduct()
  {
    this.products=[
      {productId:1,productName:'book',productPrice:300},
      {productId:2,productName:'pen',productPrice:30},
      {productId:3,productName:'pen',productPrice:30},
      {productId:4,productName:'pen',productPrice:30},
      {productId:5,productName:'pen',productPrice:30},

    ]
    return this.products;

  }
}
export class Product
  {
    productId:number;
    productName:string;
    productPrice:number;
    constructor(productId:number,productName:string,productPrice:number)
    {
      this.productId=productId;
      this.productName=productName;
      this.productPrice=productPrice;

    }
 
    

  }
