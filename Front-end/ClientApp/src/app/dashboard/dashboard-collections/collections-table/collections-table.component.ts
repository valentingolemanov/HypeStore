import {Component, Input, OnInit, ViewChild} from '@angular/core';
import { Collection } from 'src/app/models/Collection';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { CollectionsService } from 'src/app/services/collections.service';
import {Router} from '@angular/router';
import { animate, state, style, transition, trigger } from '@angular/animations';
import {MatDialog} from '@angular/material/dialog';
import {AlertifyService} from './../../../services/alertify.service';
import {CollectionDeleteDialogComponent} from './collection-delete-dialog/collection-delete-dialog.component';
import {SelectionModel} from '@angular/cdk/collections';

@Component({
  selector: 'app-collections-table',
  templateUrl: './collections-table.component.html',
  styleUrls: ['./collections-table.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CollectionsTableComponent implements OnInit {
  columnsToDisplay : string[] = ['select', 'Id', 'ImageUrl',  'Name', ];
  dataSource: MatTableDataSource<Collection>;
  expandedElement: Collection | null;
  selection = new SelectionModel<Collection>(true, []);

 @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
 @ViewChild(MatSort, {static: true}) sort: MatSort;


 isExpansionDetailRow = (index, row) => row.hasOwnProperty('detailRow');
 @Input() collections: Array<Collection>;
  constructor(private service: CollectionsService,
    private router: Router,
    private alertify: AlertifyService,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.dataSource = new MatTableDataSource(this.collections);
    console.log(this.dataSource);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
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
  checkboxLabel(row?: Collection): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.Id + 1}`;
  }

  openDeleteDialog(id: number) {

    this.dialog.open(CollectionDeleteDialogComponent,
      {data : {
        productId: id,
      }});
  }
}


