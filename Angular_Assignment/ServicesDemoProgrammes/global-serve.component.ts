import { Component, OnInit } from '@angular/core';
import { Product, ServiceGlobalDemoService } from '../service-global-demo.service';

@Component({
  selector: 'app-global-serve',
  templateUrl: './global-serve.component.html',
  styleUrls: ['./global-serve.component.css']
})
export class GlobalServeComponent implements OnInit {
  MyProduct:Product[]=[];

  constructor(public _productservice:ServiceGlobalDemoService) { }

  ngOnInit(): void {
  }
  getProductDetails()
  {
    this.MyProduct=this._productservice.getProduct();
    console.log(this.MyProduct);
  }

}
