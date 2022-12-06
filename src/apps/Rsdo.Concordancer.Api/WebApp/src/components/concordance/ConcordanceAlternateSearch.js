import ConcordanceAlternateSearchItem from './ConcordanceAlternateSearchItem';
import styles from './ConcordanceAlternateSearch.module.scss';

const ConcordanceAlternateSearch = (props) => {
    return (
        <div className={styles.alternateSearch}>
            <h2>{props.title}</h2>
            <ul>
                {props.items.map((x,i) => <ConcordanceAlternateSearchItem key={i} filterKey={x.key} title={x.title} count={x.count} search={x.search} />)}
            </ul>
        </div>
    );
};

export default ConcordanceAlternateSearch;