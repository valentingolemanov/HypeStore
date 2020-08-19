import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-gendercollection-list',
  templateUrl: './gendercollection-list.component.html',
  styleUrls: ['./gendercollection-list.component.css']
})
export class GendercollectionListComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  collections: Array<any>  = [
    {
      Title: 'MEN',
      ImageUrl: 'https://cdn.vox-cdn.com/thumbor/JqVWaWAV3PgNcXVUrHu5RO-QMTo=/247x0:2913x2000/1400x1050/filters:focal(247x0:2913x2000):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/49307093/GettyImages-509643658.0.0.jpg'
    },
    {
      Title: 'WOMEN',
      ImageUrl: 'https://image-cdn.hypb.st/https%3A%2F%2Fhypebeast.com%2Fimage%2F2020%2F05%2Fcommon-ace-Romy-Samuel-Sophia-Chang-interview-founders-hypebae-0-1.jpg?quality=95&w=1170&cbr=1&q=90&fit=max'
    }
  ]
}
