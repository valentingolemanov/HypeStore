import {Component, Input, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { ProductsService } from 'src/app/services/products.service';
import {Product} from '../../../models/Product';
import { animate, state, style, transition, trigger } from '@angular/animations';
import {Router} from '@angular/router';
import { AlertifyService } from 'src/app/services/alertify.service';
import {MatDialog} from '@angular/material/dialog';
import {AddProductComponent} from './../products-table/add-product/add-product.component'
import {SelectionModel} from '@angular/cdk/collections';
import { Collection } from 'src/app/models/Collection';
import {Brand} from './../../../models/Brand';
import { MatTable } from '@angular/material/table';

@Component({
    selector: 'app-products-table',
    templateUrl: './products-table.component.html',
    styleUrls: ['./products-table.component.css'],
    animations: [
      trigger('detailExpand', [
        state('collapsed', style({height: '0px', minHeight: '0'})),
        state('expanded', style({height: '*'})),
        transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
      ]),
    ],
    })

export class ProductsTableComponent implements OnInit {
   columnsToDisplay : string[] = ['select', 'Id', 'Title',  'AddedOn', 'LastModified'];
   dataSource: MatTableDataSource<Product>;
   expandedElement: Product | null;
   selection = new SelectionModel<Product>(true, []);

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatTable, {static: true}) table: MatTable<any>;

  isExpansionDetailRow = (index, row) => row.hasOwnProperty('detailRow');
  @Input() products: Array<Product>;
  @Input() brands: Array<Brand>;
  @Input() collections: Array<Collection>


  constructor(private service: ProductsService,
    private router: Router,
    private alertify: AlertifyService,
    public dialog: MatDialog) {


  }

  ngOnInit() {
        this.dataSource = new MatTableDataSource(this.products);
        console.log(this.dataSource);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
  }


  refreshTable(){
    this.table.renderRows();
  }

  openAddProductDialog() {
    const dialogRef = this.dialog.open(AddProductComponent,
      {
        data: {
          brands: this.brands,
          collections: this.collections,
          refreshTable: this.refreshTable,
          table: this.table,
        }
      });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }


  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
        this.selection.clear() :
        this.dataSource.data.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: Product): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.Id + 1}`;
  }
}

