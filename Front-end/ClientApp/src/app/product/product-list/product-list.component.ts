import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {



  ngOnInit(): void {
  }

  models: Array<any> = [
    {
      Id: '1',
      Title: 'BAPE x PUBG Hoodie',
      Price: (199.99).toFixed(2),
      ImageUrl: 'https://d1f7geppf3ca7.cloudfront.net/origin/643410/bape-x-pubg-shark-full-zip-hoodie-orange__01_1578402699555.jpg',

    },
    {
      Id: '2',
      Title: 'Supreme Hoodie',
      Price: (179.99).toFixed(2),
      ImageUrl: 'https://cdn1.focus.bg/bazar/64/pics/649d0d3f9d246b1beed5d8f17d59449d.jpg',

    },
    {
      Id: '3',
      Title: 'Yeezy Boost 350 V2 Zyon',
      Price: (299.99).toFixed(2),
      ImageUrl: 'https://stockx.imgix.net/adidas-Yeezy-Boost-350-V2-Zyon-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1596134320',

    },
    {
      Id: '4',
      Title: 'Nike Air Max Box',
      Price: (399.99).toFixed(2),
      ImageUrl: 'https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/941b669b-e6bf-4a62-9de1-9bfbb370a048/air-max-box-training-shoe-SVjCTS.jpg',

    }

  ]
}
